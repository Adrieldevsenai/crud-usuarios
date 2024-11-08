using ExoApi.Domains;
using ExoApi.Repositores;
using ExoApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioRepository _usuariosRepository;

        public UsuariosController(UsuarioRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;

        }
        [HttpGet]

        public IActionResult ListarUsuarios()
        {
            return StatusCode(200, _usuariosRepository.Listar());
        }

        [HttpPost]
        public IActionResult CriarUsuario(Usuario usuario)
        {
            _usuariosRepository.Criar(usuario);

            return StatusCode(201);
        }


    }

        [HttpPut("{id}")]

        public IActionResult AtualizarUsuario(int id, Usuario usuario)
        {
        if (_usuarioRepository.BuscarPorId(id) == null)

            return StatusCode(404)
        }
         _usuarioRepository.Atualizar(id, usuario);

        return StatusCode(204);

    [HttpDelete("id")]

    public IActionResult Deletar(int id) 
    {
        if(_usuarioRepository.BuscarPorId(id) == null) 
        {
            return StatusCode(404);
        }

        _usuarioRepository.Deletar(id);

        return StatusCode(204);

    }

 }
