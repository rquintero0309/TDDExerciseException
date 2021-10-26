using NUnit.Framework;
using claseMath;

namespace claseMath.Test
{
    public class Tests
    {
        private claseMath _math;

        [OneTimeSetUp]

        [SetUp]
        public void Setup()
        {
            //lo que valla aqui
            _math = new claseMath();
           

        }

        [Test]
        public void Suma_Dos_Argumentos()
        {
            var result = _math.Add(1, 2);
            //Assert.AreEqual(result,3);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Resta_Dos_Argumentos_1()
        {
            var result = _math.Subs(2, 2);

            Assert.That(result, Is.EqualTo(0));
            //Assert.AreEqual(result, 4);
        }


        [Test]
        public void Resta_Dos_Argumentos()
        {
            var result = _math.Subs(1, 2);
            //Assert.AreEqual(result,3);

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Suma_Dos_Argumentos_1()
        {
            var result = _math.Add(2, 2);

            Assert.That(result, Is.EqualTo(4));
            //Assert.AreEqual(result, 4);
        }


        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]        
        public void Obtener_el_Valor_Mayor(int a, int b, int valoresperado)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }

        [TestCase(1, 1, 7)]
        public void Obtener_el_Valor_Mayor_1(int a, int b, int valoresperado)
        {
            var result = _math.Max(a, b);

            Assert.That(result + 6, Is.EqualTo(valoresperado));
            //Assert.AreEqual(result, 4);
        }

        [Test]
        public void Dividir_Dos_Argumentos()
        {
            var result = _math.Divide(2, 2);

            Assert.That(result, Is.EqualTo(1));
            
        }

        [Test]
        public void Dividir_Excepcion_1()
        {
            int dividendo = 8;
            int divisor = 0;

            //Assert.That(()=> _math.Divide(dividendo,divisor), Throws.InvalidOperationException);
            Assert.That(() => _math.Divide(dividendo, divisor), Throws.Exception);


        }

    }
}
