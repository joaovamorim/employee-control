using webapínet6_crud.Models;

namespace webapínet6_crud.Service
{
    public interface IFuncionarioInterface
    {
        // GET
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        
        // POST
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);

        // GET {id}
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioId(int id);

        // PUT
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editarFuncionario);

        // DELETE
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);

        // PUT {id}
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}