using System;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Scripts.Scripts
{
    internal static class Instantiation
    {
        public static async Task InstantiateRoadPieces( this GameObject piece, int count)
        {
            var distance = 294.4f;
            var position = piece.transform.position;
            for (int i = 0; i < count; i++)
            {
                var newPiece=Object.InstantiateAsync(piece
                    , new Vector3(position.x,position.y,position.z+distance*i)
                    , piece.transform.rotation);
            }
            await Task.Delay(1);
        }
    }
}