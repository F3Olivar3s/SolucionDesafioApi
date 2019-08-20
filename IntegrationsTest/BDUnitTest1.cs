using Contracts.BD.Door;
using Factory;
using IntegrationsTest.Models;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create()
        {
            Empresa emp = new Empresa()
            {
                Nombre = "UsuarioTest",
                Apellido = "ApellidoT",
                Email = "Test@mail.cl"
            };
            Access bd = new Access();
            var _operations = BDFactory.GetEmpleado();
            var result = _operations.Create(emp, bd).Result;

            Assert.IsTrue(result);
        }
        [Test]
        public void Update()
        {
            Empresa emp = new Empresa()
            {
                Nombre = "Usuario",
                Apellido = "ApellidoT",
                Email = "Test@mail.cl",
                Id = 2
            };
            Access bd = new Access();
            var _operations = BDFactory.GetEmpleado();
            var result = _operations.Update(emp, bd).Result;

            Assert.IsTrue(result);
        }
        [Test]
        public void ReadById()
        {
            Access bd = new Access();
            var _operations = BDFactory.GetEmpleado();
            var result = _operations.GetEmpleado(2, bd).Result;

            Assert.IsTrue(result.Id == 2);
        }
        [Test]
        public void ReadAll()
        {
            Access bd = new Access();
            var _operations = BDFactory.GetEmpleado();
            var result = _operations.GetAll(bd).Result;

            Assert.IsTrue(result.Count > 0);
        }
        [Test]
        public void Delete()
        {
            Access bd = new Access();
            var _operations = BDFactory.GetEmpleado();
            var result = _operations.Delete(0,bd).Result;

            Assert.IsTrue(result);
        }
    }
}