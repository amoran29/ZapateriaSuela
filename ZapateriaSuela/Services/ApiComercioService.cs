using System.Net.Http.Json;
using ZapateriaSuela.Models;

namespace ZapateriaSuela.Services
{
    public class ApiComercioService
    {
        private readonly HttpClient _http;

        public ApiComercioService(HttpClient http)
        {
            _http = http;
        }

        // Obtener productos
        public async Task<List<ProductoApi>>
            ObtenerProductos()
        {
            return await _http.GetFromJsonAsync<List<ProductoApi>>(
                "https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net/api/comercio/productos"
            ) ?? new();
        }

        // Obtener categorías
        public async Task<List<CategoriaApi>>
            ObtenerCategorias()
        {
            return await _http.GetFromJsonAsync<List<CategoriaApi>>(
                "https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net/api/comercio/categorias"
            ) ?? new();
        }

        // Filtrar por categoría
        public async Task<List<ProductoApi>>
            ObtenerProductosPorCategoria(int categoriaId)
        {
            return await _http.GetFromJsonAsync<List<ProductoApi>>(
                $"https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net/api/comercio/productos/categoria/{categoriaId}"
            ) ?? new();
        }
    }
}