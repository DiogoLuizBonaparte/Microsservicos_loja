using AutoMapper;
using Geek_Product.Data.ValueObjects;
using mgtt.Model;
using mgtt.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace Geek_Product.Repository
{
    public class ProductRepository : IProductRepository
    {


        private readonly SQLContext _context;
        private IMapper _mapper;
        public ProductRepository(SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
                
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            List<Product> product =
                await _context.Products.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(product);
        }
        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVO> Update(ProductVO ProductVO)
        {
            throw new NotImplementedException();
        }

    }
}
