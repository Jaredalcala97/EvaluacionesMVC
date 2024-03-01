document.addEventListener('DOMContentLoaded', function () {
    init();
});

function init() {
    // Definición de los enlaces para el cambio de páginas dentro de la app
    const logoutLink = document.getElementById('Index');
    const loginLink = document.getElementById('Botones');
    // Datos del usuario normal (Supervisor)
    const userLink = document.getElementById('Sesion');
    const afirmarLink = document.getElementById('Afirmar');
    const consultaLink = document.getElementById('Consulta');
    const nuevasEvLink = document.getElementById('NuevaE');
    const evaluarLink = document.getElementById('Evaluacion');

    // Datos de administrador
    const AdminLink = document.getElementById('SesionAdmin');
    const firmasLink = document.getElementById('Firmas');
    const newUsertLink = document.getElementById('NewUser');
    const tabpaytLink = document.getElementById('TabPay');
    const statustLink = document.getElementById('Status');

    // Función para cambiar el contenido según el enlace seleccionado
    function redirectToPage(event) {
        event.preventDefault(); // Prevenir comportamiento predeterminado del enlace

        // Obtener el id del enlace seleccionado
        const id = event.target.id;

        // Cambiar contenido según el enlace seleccionado
        switch (id) {
            case 'Botones':
                window.location.href = 'Botones';
                break;
            case 'Index':
                window.location.href = 'Index';
                break;
            case 'Sesion':
                window.location.href = 'Sesion';
                break;
            case 'Afirmar':
                window.location.href = 'Afirmar';
                break;
            case 'NuevaE':
                window.location.href = 'NuevaE';
                break;
            case 'Evaluacion':
                window.location.href = 'Evaluacion';
                break;
            case 'SesionAdmin':
                window.location.href = 'SesionAdmin';
                break;
            case 'Firmas':
                window.location.href = 'Firmas';
                break;
            case 'NewUser':
                window.location.href = 'NewUser';
                break;
            case 'TabPay':
                window.location.href = 'TabPay';
                break;
            case 'Status':
                window.location.href = 'Status';
                break;
            default:
                window.location.href = 'Error';
                break;
        }
    }

    // Agregar controladores de eventos a los enlaces de la barra de navegación
    const links = [logoutLink, loginLink, userLink, afirmarLink, consultaLink, nuevasEvLink, evaluarLink, AdminLink, firmasLink, newUsertLink, tabpaytLink, statustLink];
    links.forEach(link => {
        if (link) { // Verifica si el elemento existe antes de añadir el listener
            link.addEventListener('click', redirectToPage);
        }
    });
}
