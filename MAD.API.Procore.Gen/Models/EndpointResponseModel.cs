namespace MAD.API.Procore.Gen
{
    public class EndpointResponseModel
    {
        public string Description { get; set; }
        public int Status { get; set; }

        public EndpointResponseSchemaModel Schema { get; set; } 
    }
}