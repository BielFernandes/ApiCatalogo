
using APICatalogo.Context;

namespace APICatalogo.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProdutoRepository? _produtoRepo;
        public ICategoriaRepository? _categoriaRepo;

        public AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IProdutoRepository ProdutoRepository
        {

           get
            {
                //if(_produtoRepo == null)
                //{
                //    _produtoRepo = new ProdutoRepository(_context);
                //}
                //return _produtoRepo;
                return _produtoRepo ??= new ProdutoRepository(_context);
            }
        }

        public ICategoriaRepository CategoriaRepository
        {

            get
            {
                return _categoriaRepo ??= new CategoriaRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
