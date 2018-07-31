using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SM.Infrastructure.DTO;
using SM.Core.Repositories;
using AutoMapper;
using SM.Core.Domain;

namespace SM.Infrastructure.Services
{
    public class AdresService : IAdresService
    {
        private readonly IAdresRepository _repository;
        private readonly IMapper _mapper;

        public AdresService(IAdresRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AdrAdmDTO>> GetAllAdmAsync()
        {
            var repository = await _repository.GetAllAdmAsync();

            return _mapper.Map<IEnumerable<AdrAdm>, IEnumerable<AdrAdmDTO>>(repository);
        }

        public async Task<IEnumerable<AdrBudDTO>> GetAllBudAsync()
        {
            var repository = await _repository.GetAllBudAsync();

            return _mapper.Map<IEnumerable<AdrBud>, IEnumerable<AdrBudDTO>>(repository);
        }

        public async Task<IEnumerable<AdrKlaDTO>> GetAllKlaAsync()
        {
            var repository = await _repository.GetAllKlaAsync();

            return _mapper.Map<IEnumerable<AdrKla>, IEnumerable<AdrKlaDTO>>(repository);
        }

        public async Task<IEnumerable<AdrLokDTO>> GetAllLokAsync()
        {
            var repository = await _repository.GetAllLokAsync();

            return _mapper.Map<IEnumerable<AdrLok>, IEnumerable<AdrLokDTO>>(repository);
        }

        public async Task<IEnumerable<AdrOsiDTO>> GetAllOsiAsync()
        {
            var repository = await _repository.GetAllOsiAsync();

            return _mapper.Map<IEnumerable<AdrOsi>, IEnumerable<AdrOsiDTO>>(repository);
        }

        public async Task<IEnumerable<AdrUliDTO>> GetAllUliAsync()
        {
            var repository = await _repository.GetAllUliAsync();

            return _mapper.Map<IEnumerable<AdrUli>, IEnumerable<AdrUliDTO>>(repository);
        }

        public async Task<IEnumerable<BranzaDTO>> GetAllBranzeAsync()
        {
            var repository = await _repository.GetAllBranzeAsync();

            return _mapper.Map<IEnumerable<Branza>, IEnumerable<BranzaDTO>>(repository);
        }

        public async Task<IEnumerable<OsobaDTO>> GetAllPracownicyAsync()
        {
            var repository = await _repository.GetAllPracownicyAsync();

            return _mapper.Map<IEnumerable<Osoba>, IEnumerable<OsobaDTO>>(repository);
        }

        public async Task<IEnumerable<AdrKlaDTO>> GetKlatkiAsync(string budynekId)
        {
            var repository = await _repository.GetKlatkiAsync(budynekId);

            return _mapper.Map<IEnumerable<AdrKla>, IEnumerable<AdrKlaDTO>>(repository);
        }

        public async Task<IEnumerable<AdrLokDTO>> GetLokaleAsync(string klatkaId, string budynekId)
        {
            var repository = await _repository.GetLokaleAsync(klatkaId, budynekId);

            return _mapper.Map<IEnumerable<AdrLok>, IEnumerable<AdrLokDTO>>(repository);
        }

        public async Task<string> CreateStringAddress(string budynekId, string klatkaId, string lokalId)
        {
            var wynik = "";
            string budynek = "";
            string klatka = "";
            string lokal = "";

            if (budynekId.Length == 0)
                budynek = "????";

            else
                budynek = budynekId;

            if (klatkaId.Length == 0)
                klatka = "????";

            else
                klatka = klatkaId;

            if (lokalId.Length == 0)
                lokal = "???";

            else
                lokal = lokalId;


            var budynekDb = await _repository.GetBudynek(budynek);
            wynik = budynekDb.id_adm + "-" + budynekDb.id_osie + "-" + budynekDb.id_ulic + "-" + budynek + "-" + klatka.PadLeft(4, ' ') + "-" + lokal.PadLeft(3, ' ');

            return wynik;
        }

        public async Task<string> FindAddressFromString(string adres = "")
        {
            string wynik = "";

            if(!String.IsNullOrWhiteSpace(adres))
            {
                if (adres.Length == 24)
                {
                    string idBudynku = adres.Substring(10, 4).TrimStart('0');
                    string nrKlatki = adres.Substring(15, 5).Trim();
                    string nrLokalu = adres.Substring(21, 3).Trim();

                    var AdrBudynkow = await _repository.GetBudynek(Int32.Parse(idBudynku));
                    
                    wynik = _mapper.Map<AdrBud, AdrBudDTO>(AdrBudynkow).ulica + " " + nrKlatki + " m. " + nrLokalu;
                }

                else if (adres.Length == 23)
                {
                    string idBudynku = adres.Substring(10, 4).TrimStart('0');
                    string nrKlatki = adres.Substring(15, 4).Trim();
                    string nrLokalu = adres.Substring(20, 3).Trim();

                    var AdrBudynkow = await _repository.GetBudynek(Int32.Parse(idBudynku));

                    wynik = _mapper.Map<AdrBud, AdrBudDTO>(AdrBudynkow).ulica + " " + nrKlatki + " m. " + nrLokalu;
                }
            }

            return wynik;
        }
    }
}
