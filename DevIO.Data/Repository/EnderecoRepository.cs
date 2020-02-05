using System;
using System.Threading.Tasks;
using DevApi.Business.Intefaces;
using DevApi.Business.Models;
using DevApi.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevApi.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}