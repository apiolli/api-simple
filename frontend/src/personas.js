const btnPerros = document.querySelector("#btn-perro");

document.addEventListener("DOMContentLoaded", () => {
  obtenerPersonas();
  btnPerros.addEventListener("click", () => {
    window.location.href = "perros.html";
  });
});

async function obtenerPersonas() {
  const url = "http://localhost:5134/api/personas";
  const respuesta = await fetch(url)
    .then((res) => res.json())
    .then((data) => data);

  llenarTablaPersonas(respuesta);
}

function llenarTablaPersonas(data) {
  const tablaPersonas = document.querySelector("#tabla-personas");
  data.forEach((persona) => {
    const fila = document.createElement("tr");
    const { id, matricula, nombre, carrera } = persona;
    fila.innerHTML += `<th>${id}</th>
            <td>${matricula}</td>
            <td>${nombre}</td>
            <td>${carrera}</td>`;

    tablaPersonas.appendChild(fila);
  });
}
