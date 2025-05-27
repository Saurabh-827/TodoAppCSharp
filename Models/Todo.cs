using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Components.Web;
namespace TodoApp.Models;

public class Todo
{
    public Guid Id { get; set; }

    [DisplayName("Title")]
    [Required(ErrorMessage = "Title is required")]
    public string? Title { get; set; }

    [DisplayName("Completed")]
    public bool Done { get; set; }

    [DisplayName("Created At")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [DisplayName("Last Update")]
    public DateTime LastUpdate { get; set; } = DateTime.Now;
}