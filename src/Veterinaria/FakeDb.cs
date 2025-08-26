// Nota: Para simplificar el examen, usamos listas en memoria.
using System.Collections.Concurrent;
using Veterinaria.Models;

namespace Veterinaria
{
    public static class FakeDb
    {
        public static ConcurrentDictionary<int, Pet> Pets = new();
        public static ConcurrentDictionary<int, Product> Products = new();
        private static int petSeq = 0;
        private static int prodSeq = 0;

        public static int NextPetId() => System.Threading.Interlocked.Increment(ref petSeq);
        public static int NextProductId() => System.Threading.Interlocked.Increment(ref prodSeq);
    }
}
