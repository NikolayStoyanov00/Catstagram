namespace Catstagram.Features.Cats
{
    using System.ComponentModel.DataAnnotations;
    using static Data.Validation.Cat;

    public class CreateCatRequestModel
    {
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}

