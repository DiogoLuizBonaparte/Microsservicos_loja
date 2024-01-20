using AutoMapper;
using Geek_Product.Data.ValueObjects;
using mgtt.Model;

namespace Geek_Product.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration ResgisterMap()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, Product>();

            });
            return mappingConfig;
        }
    }
}
