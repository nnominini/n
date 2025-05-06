using System.Collections.Generic;
using System.Windows.Forms;

public static class FormManager
{
    // Form history хадгалах Stack
    private static Stack<Form> history = new Stack<Form>();

    // Шинэ Form нээх үед: одоогийн Form-г history-д хадгалаад, шинэ Form-г харуулна
    public static void OpenForm(Form currentForm, Form newForm)
    {
        history.Push(currentForm);
        currentForm.Hide();
        newForm.Show();
    }

    // Буцах товч дарсан үед: сүүлд байсан Form-г буцааж харуулна
    public static void GoBack(Form currentForm)
    {
        if (history.Count > 0)
        {
            Form previousForm = history.Pop();
            currentForm.Close();
            previousForm.Show();
        }
        else
        {
          
            Application.Exit(); // эсвэл main form руу буцааж болно
        }
    }
}
