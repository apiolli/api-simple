const btnPerros = document.querySelector("#btn-perro");
const btnPersona = document.querySelector("#btn-persona");

document.addEventListener("DOMContentLoaded", () => {
  btnPerros.addEventListener("click", () => {
    window.location.href = "perros.html";
  });

  btnPersona.addEventListener("click", () => {
    window.location.href = "index.html";
  });
});
