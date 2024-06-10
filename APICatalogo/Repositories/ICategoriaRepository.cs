using APICatalogo.Models;

namespace APICatalogo.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetCategorias();
        Categoria GetCategoria(int id);
        Categoria CreateCategoria(Categoria categoria);
        Categoria Update(Categoria categoria);
        Categoria DeleteCategoria(int id);
    }
}
