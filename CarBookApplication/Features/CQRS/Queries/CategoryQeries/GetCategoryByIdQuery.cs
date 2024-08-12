namespace CarBookApplication.Features.CQRS.Queries.CategoryQeries
{
    public class GetCategoryByIdQuery
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
