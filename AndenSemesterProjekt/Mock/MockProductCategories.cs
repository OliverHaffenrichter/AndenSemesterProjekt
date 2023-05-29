using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockProductCategories
    {
        private static List<ProductCategoryList> productsCategories = new List<ProductCategoryList>()
        {
            new ProductCategoryList("cat1"),
            new ProductCategoryList("cat2"),
            new ProductCategoryList("cat3"),
            new ProductCategoryList("cat4"),
            new ProductCategoryList("cat5"),
            new ProductCategoryList("cat6"),
            new ProductCategoryList("cat7")
        };

        public static List<ProductCategoryList> GetMockProductCategoreis()
        {
            return productsCategories;
        }
    }
}
