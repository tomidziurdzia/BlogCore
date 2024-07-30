using BlogCore.Models;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository;

public interface ICategoriaRepository : IRepository<Categoria>
{
    // Metodo para un dropdown
    void Update(Categoria categoria);
    
}