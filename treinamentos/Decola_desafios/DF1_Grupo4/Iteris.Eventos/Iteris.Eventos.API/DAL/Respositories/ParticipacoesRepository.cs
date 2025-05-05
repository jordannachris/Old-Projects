using Iteris.Eventos.API.Domain.DTO;
using Iteris.Eventos.API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iteris.Eventos.API.DAL.Respositories
{
    public class ParticipacoesRepository
    {
        private readonly projeto_app_eventosContext _participacaoContext;

        public ParticipacoesRepository(projeto_app_eventosContext participacoesContex)
        {
            _participacaoContext = participacoesContex;
        }

        public async Task<Participacao> PesquisaPorId(int id)
        {
            // select top 1 * from Evento
            return await _participacaoContext.Participacaos.FindAsync(id);
        }

        public async Task<Participacao> Cadastrar(Participacao nova)
        {
            _participacaoContext.Participacaos.Add(nova);
            await _participacaoContext.SaveChangesAsync(); // Todo o Entiy está preparado para isso
            return nova;
        }

        public async Task<int> QuantidadeParticipantes(int? id)
        {
            var resultado = await _participacaoContext.Participacaos.Where(x => x.IdEvento == id).CountAsync();

            return resultado;
        }

        public async Task<ParticipacaoResponse> InscreverParticipante(int idParticipante, int idEnvento)
        {
            var resultado = await PesquisaPorId(idParticipante);

            resultado.IdEvento = idEnvento;
            await _participacaoContext.SaveChangesAsync();

            return new ParticipacaoResponse(resultado);
        }

        public async Task<ParticipacaoResponse> CadastrarAvaliacao(int idParticipante, int? nota, string comentario)
        {
            var resultado = await PesquisaPorId(idParticipante);

            resultado.Nota = nota;
            resultado.Comentario = comentario;
            await _participacaoContext.SaveChangesAsync();

            return new ParticipacaoResponse(resultado);
        }

        public async Task<ParticipacaoResponse> AlterarFlag(int idParticipante)
        {
            var resultado = await PesquisaPorId(idParticipante);

            resultado.FlagPresente = true;
            _participacaoContext.SaveChangesAsync();

            return new ParticipacaoResponse(resultado);
        }
    }
}
