using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();
        public void OnGet(int skip=0, int take=25)
        {
            var temp = new List<Category>();
            for (var i = 0; i <= 1789; i++)
            {
                temp.Add(item: new Category(i, Title: $"Categoria {i}", Price: i * 18.95M));
            }

            CategoryList = temp.Skip(skip).Take(take).ToList();
        }
        public void OnPost()
        {

        }
    }
    public record Category(int Id, string Title, decimal Price);
}
