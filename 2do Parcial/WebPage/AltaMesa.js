document.addEventListener("DOMContentLoaded", function (event) {
    console.info("Pruebas")
});
document.getElementById('Formulario').addEventListener('submit', function (event) {
    event.preventDefault(); 

    const Marca = document.getElementById('marca').value;
    const Nombre = document.getElementById('nombre').value;
    const FechaELiminacion = document.getElementById('fechaE').value;
    const Stock = document.getElementById('stock').value;
    const Precio = document.getElementById('precio').value;
    const Material = document.getElementById('material').value;
    const Tamaño = document.getElementById('tamaño').value;
    const Cantidad = document.getElementById('cantidad').value;

    const datos = {
        nombre: Nombre,
        marca: Marca,
        precio: Precio,
        stock: Stock,
        fechaEliminacion: FechaELiminacion,
        tamaño: Tamaño,
        material: Material,
        cantidadPersonas: Cantidad
    };
    fetch('https://localhost:44350/Mesa', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(datos)
    })
        .then(response => response.json())
        .then(data => {
            console.log('Respuesta de la API:', data);
            alert('Registro exitoso');
        })
        .catch(error => {
            console.error('Error al enviar los datos:', error);
            alert('Hubo un error al procesar el registro');
        });
});