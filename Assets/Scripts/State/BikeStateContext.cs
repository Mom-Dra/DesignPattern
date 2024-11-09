using Unity.VisualScripting;

public class BikeStateContext
{
    public IBikeState CurrentState
    {
        get; set;
    }

    private readonly BikeController bikeController;

    public BikeStateContext(BikeController bikeController)
    {
        this.bikeController = bikeController;
    }

    public void Transition()
    {
        CurrentState.Handle(bikeController);
    }

    public void Transition(IBikeState state)
    {
        CurrentState = state;
        CurrentState.Handle(bikeController);
    }
}