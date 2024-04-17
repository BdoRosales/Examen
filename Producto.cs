using System.ComponentModel.DataAnnotations;
namespace Demo4.Productos
{
    public class Producto
    {
        [Required(ErrorMessage = "El n�mero de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El n�mero de inventario debe ser positivo")]
        public string? Inventario { get; set; }


        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [MaxLength(200, ErrorMessage = "El m�ximo de caracteres es 200")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El Departamento es obligatorio")]
        public string? Departamento { get; set; }

    }
}
