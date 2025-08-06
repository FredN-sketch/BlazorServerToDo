using System.ComponentModel.DataAnnotations;

namespace BlazorServerToDo.Models
{
    public class ToDoItem // : IValidatableObject 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //do something here if needed
            if (string.IsNullOrWhiteSpace(Title))
            {
                yield return new ValidationResult("Title cannot be empty.", new[] { nameof(Title) });
            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                yield return new ValidationResult("Description cannot be empty.", new[] { nameof(Description) });
            }
        }
    }
}
