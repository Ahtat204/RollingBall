using System;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Scripts.Scripts
{
    internal static class Instantiation
    {
        public static async Task InstantiateRoadPieces(this GameObject piece, int count)
        {
            const float distance = -19.011f;
            var position = piece.transform.position;
            try
            {
                for (var i = 0; i < count; i++)
                {
                    await Task.Delay(1000);
                    var newPosition = position;
                    var newPiece = Object.Instantiate(piece, newPosition, piece.transform.rotation);
                    // Pause between spawns
                }
                await Task.Delay(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Debug.Log(e);
            }
            finally
            {
                throw new Exception("error occuried");
            }
            ;
        }
    }
}