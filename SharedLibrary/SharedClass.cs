using System.Linq;
/// <summary>
/// This library has all my shared stuff in.
/// </summary>
namespace SharedLibrary
{
    /// <summary>
    /// Contains all the shared stuff
    /// </summary>
    public class SharedClass    
    {
        /// <summary>
        /// Constructor for SharedClass
        /// </summary>
        public SharedClass()
        {
            MagicNumber = 1;
        }

        /// <summary>
        /// Multiplies the MagicNumber by another
        /// </summary>
        /// <param name="Multiplier">The number to mutiply the MagicNumber by</param>
        /// <returns>MagicNumber multiplied by Multiplier</returns>
        public int MultiplyMagicNumber(int Multiplier)
        {
            return MagicNumber * Multiplier;
        }

        /// <summary>
        /// Properties can have XML docs too!
        /// </summary>
        public int MagicNumber
        {
            get { return _magicNumber; }
            set { _magicNumber = value; }
        }
        private int _magicNumber;
        
        /// <summary>
        /// Generics get a special element: typeparam
        /// </summary>
        /// <typeparam name="T">The type parameter</typeparam>
        /// <param name="obj">The first parameter</param>
        /// <returns>Return value</returns>
        public static string ReverseToString<T>(T obj)
        {
            var orig = obj.ToString();
            var reversedCharArray = orig.ToCharArray().Reverse().ToArray();
            return new string(reversedCharArray);
        }
    }

    /// <summary>
    /// Structs can have XML comments
    /// </summary>
    public struct SharedStruct
    {
        /// <summary>
        /// Int A is best int
        /// </summary>
        public int IntA;

        /// <summary>
        /// Int B is good too
        /// </summary>
        public int IntB;
    }
}
