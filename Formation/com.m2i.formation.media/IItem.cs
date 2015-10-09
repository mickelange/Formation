namespace Formation.com.m2i.formation.media
{
    public interface IItem
    {
        string Description { get; set; }
        int Id { get; set; }
        double Prix { get; set; }
    }
}