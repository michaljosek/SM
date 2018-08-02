using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SM.Core.Domain;
using SM.Infrastructure.Paging;
using SM.Core.Repositories;
using AutoMapper;
using SM.Infrastructure.DTO;
using Microsoft.EntityFrameworkCore;

namespace SM.Infrastructure.Services
{
    public class B07_zgloService : IB07_zgloService
    {
        private readonly IB07_zgloRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public B07_zgloService(IB07_zgloRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<PagedList<B07_zgloDTO>> BrowseAsync(string sortOrder, bool orderAsc, int pageIndex, int pageSize)
        {
            var counter = await _repository.CountTotalAsync();
            var b07_zgloDb = await _repository.GetPageAsync(sortOrder, orderAsc, pageIndex, pageSize);
            var b07_zgloDTODb = _mapper.Map<IEnumerable<B07_zglo>, IEnumerable<B07_zgloDTO>>(b07_zgloDb);
            var b07_zgloDTOPaged = new PagedList<B07_zgloDTO>(b07_zgloDTODb.ToList(), counter, sortOrder, orderAsc, pageIndex, pageSize);

            return b07_zgloDTOPaged;
        }

        public async Task<B07_zgloDTO> GetZgloAsync(int id)
        {
            var b07_zgloObj = await _repository.GetZgloAsync(id);

            return _mapper.Map<B07_zglo, B07_zgloDTO>(b07_zgloObj);
        }

        public async Task<int> AddAsync()
        {
            var newZgloszenie = new B07_zglo
            {
                numer_zglo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                data_zglos = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0),
                data_oper = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0),
                id_branz = "",
                nr_prac = ""
            };

            await _repository.AddAsync(newZgloszenie);
            await _unitOfWork.CompleteSMContextAsync();

            return newZgloszenie.B07_zgloId;
        }

        public async Task RemoveAsync(int id)
        {
            await _repository.RemoveAsync(id);
            await _unitOfWork.CompleteSMContextAsync();

            await Task.CompletedTask;
        }

        public async Task UpdateAsync(B07_zgloDTO zgloszenie, int id)
        {
            var mapZgloszenie = _mapper.Map<B07_zgloDTO, B07_zglo>(zgloszenie);
            await _repository.UpdateAsync(mapZgloszenie, id);
            await _unitOfWork.CompleteSMContextAsync();

            await Task.CompletedTask;
        }
    }
}
