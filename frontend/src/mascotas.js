const btnPersona = document.querySelector("#btn-persona");

document.addEventListener("DOMContentLoaded", () => {
  obtenerMascotas();
  btnPersona.addEventListener("click", () => {
    window.location.href = "index.html";
  });
});

async function obtenerMascotas() {
  const url = "http://localhost:5134/api/mascotas";
  const respuesta = await fetch(url)
    .then((res) => res.json())
    .then((data) => data);

  llenarTablaPerros(respuesta);
}

function llenarTablaPerros(data) {
  const tablaPerros = document.querySelector("#tabla-perros");
  data.forEach((perro) => {
    const fila = document.createElement("tr");
    const { id, nombre, raza, edad } = perro;
    fila.innerHTML = `<th>${id}</th>
            <td>${nombre}</td>
            <td>${raza}</td>
            <td>${edad}</td>`;

    tablaPerros.appendChild(fila);
  });
}
