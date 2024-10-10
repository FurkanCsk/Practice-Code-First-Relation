namespace Practice___Code_First_Relation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public List<PostEntity> Posts { get; set; }
    }
}
