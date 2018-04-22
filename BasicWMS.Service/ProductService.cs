using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Data.Repositories;
using BasicWMS.Model;
using BasicWMS.Service.Interfaces;

namespace BasicWMS.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetProducts()
        {
            _productRepository.Add( new Product()
                {
                    Codigo = "SL2367",
                    Nombre = "Escobas",
                    CantidadDisponible = 25,
                    CantidadMinima = 5,
                    Descripcion = "Escobas de plastico",
                    Categoria = new Category()
                {
                    Nombre = "Controlados"
                },
                    CategoriaId = 0
            });
            _unitOfWork.Commit();
            var products = _productRepository.GetAll();
            _unitOfWork.Commit();
            return products;
        }

        public Product GetProduct(int id)
        {
            var product = _productRepository.GetById(id);
            _unitOfWork.Commit();
            return product;
        }

        public Product GetProduct(string name)
        {
            var product = _productRepository.GetByName(name);
            _unitOfWork.Commit();
            return product;
        }

        public void CreateProduct(Product product)
        {
            _productRepository.Add(product);
            _unitOfWork.Commit();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _unitOfWork.Commit();
        }

        public void DeleteProduct(Product product)
        {
            _productRepository.Delete(product);
            _unitOfWork.Commit();
        }

        public IEnumerable<Product> GetProductForPage(int pageSize, int numPage)
        {
            var products = _productRepository.GetProductForPage(pageSize, numPage);
            _unitOfWork.Commit();
            return products;
        }
    }
}
