using System.ComponentModel.DataAnnotations;

namespace MakeIt.Dtos.TodoDtos;

public record class TodoDto
(
    int Id,
    [Required][StringLength(100)] string Name,
    bool IsCompleted
);
