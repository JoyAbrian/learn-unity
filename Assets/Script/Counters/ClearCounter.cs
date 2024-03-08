using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no kitchen object here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
                player.GetKitchenObject().setKitchenObjectParent(this);
            } else
            {
                // Player not carrying anything
            }

        } else
        {
            // There is kitchen object here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
            } else
            {
                // Player is not carrying anything
                GetKitchenObject().setKitchenObjectParent(player);
            }
        }
    }
}
