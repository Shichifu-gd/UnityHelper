public class Presenter : IPresenter
{
    private View view;

    public Presenter(View newView, Model newModel)
    {
        view = newView;
        var Model = newModel;
        Model.Death += Death;
        Model.OnHealthChanged += RedirectValues;
        view.OnTakeDamge += Model.ResiveDemage;
        view.OnUpdateValues += Model.UpdateValues;
    }

    public void Death()
    {
        view.ObjectShutdown();
    }

    public void RedirectValues(int health, int maxHealth)
    {
        view.HealthAnimation(health, maxHealth);
    }
}