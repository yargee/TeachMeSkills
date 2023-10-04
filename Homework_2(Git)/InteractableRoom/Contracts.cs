using InteractableRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


public interface IInteractable
{
    public string Introducion { get; }
    public string[] InteractionResults { get; }
    void Interact();
}

public interface IDestroyable
{
    public void Destroy();
}