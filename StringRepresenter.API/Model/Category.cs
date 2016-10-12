namespace StringRepresenter.API.Model
{
    public class Category
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, int? parentId, string categoryName)
        {
            Id = id;
            ParentId = parentId == 0 ? null : parentId;
            CategoryName = categoryName;
        }
    }
}
