namespace Relacion2_CarlosMN;

public partial class Ejercicio01 : ContentPage
{
	public Ejercicio01()
	{
		InitializeComponent();
	}

    #region LISTA PARA GUARDAR LOS NUMEROS Y VARIABLES PARA LAS OPERACIONES MATEMATICAS
    List<int> numeros = new List<int>();  // Lista para almacenar todos los n�meros ingresados

    // Inicializacion de las operaciones de la Calculadora
    bool multiplicando = false;
    bool sumando = false;
    bool dividiendo = false;
    bool restando = false;
    bool porcentaje = false;
    #endregion

    #region BOTONES NUMEROS
    /// <summary>
    /// A�adimos funcionalidad a los botones asignados a los numeros
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_0(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "0";  // Agrega "7" al texto actual
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "1";  // Agrega "1" al texto actual
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "2";  // Agrega "2" al texto actual
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "3";  // Agrega "3" al texto actual
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "4";  // Agrega "4" al texto actual
    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "5";  // Agrega "5" al texto actual
    }

    private void Button_Clicked_6(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "6";  // Agrega "6" al texto actual
    }

    private void Button_Clicked_7(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "7";  // Agrega "7" al texto actual
    }

    private void Button_Clicked_8(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "8";  // Agrega "8" al texto actual
    }

    private void Button_Clicked_9(object sender, EventArgs e)
    {
        EntradaCalculadora.Text += "9";  // Agrega "9" al texto actual
    }
    #endregion

    #region BOTONES OPERACIONES MATEMATICAS
    /// <summary>
    /// Botones asignados a hacer el tipo de operaciones que usuario desee
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_Multiplicar(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa un n�mero antes de realizar la operaci�n.", "OK");
            return;
        }

        if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
        {
            // A�adir el n�mero a la lista
            numeros.Add(numero);

            // Mostrar la operaci�n con el s�mbolo de multiplicaci�n
            EntradaCalculadora.Text += " * ";

            multiplicando = true;
        }
        else
        {
            DisplayAlert("Error", "El valor ingresado no es un n�mero v�lido.", "OK");
        }
    }
    private void Button_Clicked_Dividir(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa un n�mero antes de realizar la operaci�n.", "OK");
            return;
        }

        if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
        {
            // A�adir el n�mero a la lista
            numeros.Add(numero);

            // Mostrar la operaci�n con el s�mbolo de division
            EntradaCalculadora.Text += " � ";

            dividiendo = true;
        }
        else
        {
            DisplayAlert("Error", "El valor ingresado no es un n�mero v�lido.", "OK");
        }
    }

    private void Button_Clicked_Sumar(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa un n�mero antes de realizar la operaci�n.", "OK");
            return;
        }

        if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
        {
            // A�adir el n�mero a la lista
            numeros.Add(numero);

            // Mostrar la operaci�n con el s�mbolo de la suma
            EntradaCalculadora.Text += " + ";

            sumando = true;
        }
        else
        {
            DisplayAlert("Error", "El valor ingresado no es un n�mero v�lido.", "OK");
        }
    }

    private void Button_Clicked_Restar(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa un n�mero antes de realizar la operaci�n.", "OK");
            return;
        }

        if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
        {
            // A�adir el n�mero a la lista
            numeros.Add(numero);

            // Mostrar la operaci�n con el s�mbolo de la resta
            EntradaCalculadora.Text += " - ";

            restando = true;
        }
        else
        {
            DisplayAlert("Error", "El valor ingresado no es un n�mero v�lido.", "OK");
        }
    }

    private void Button_Clicked_Porcentaje(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
        {
            DisplayAlert("Error", "Por favor, ingresa un n�mero antes de realizar la operaci�n.", "OK");
            return;
        }

        if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
        {
            // A�adir el n�mero a la lista
            numeros.Add(numero);

            // Mostrar la operaci�n con el s�mbolo del porcentaje
            EntradaCalculadora.Text += " % ";

            porcentaje = true;
        }
        else
        {
            DisplayAlert("Error", "El valor ingresado no es un n�mero v�lido.", "OK");
        }
    }
    #endregion

    #region BOTON QUE MOSTRARA EL RESULTADO EN EL ENTRY
    /// <summary>
    /// Boton que limpiara el Entry y mostrara el resultado de la operacion
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_Igual(object sender, EventArgs e)
    {
        if (sumando)
        {
            // A�adir el �ltimo n�mero despu�s del s�mbolo "+"
            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
            {
                numeros.Add(ultimoNumero);  // A�adir el �ltimo n�mero a la lista

                // Realizar la suma acumulada
                int resultado = 0;  // Empezamos con 0 porque vamos a sumar

                foreach (int num in numeros)
                {
                    resultado += num;
                }

                // Borrar el Entry y mostrar el resultado
                EntradaCalculadora.Text = resultado.ToString();

                // Reiniciar la lista de n�meros y el estado
                numeros.Clear();
                sumando = false;
            }
        }

        if (restando)
        {
            // A�adir el �ltimo n�mero despu�s del s�mbolo "-"
            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
            {
                numeros.Add(ultimoNumero);  // A�adir el �ltimo n�mero a la lista

                // Inicializar el resultado con el primer n�mero de la lista
                int resultado = numeros[0];

                // Realizar la resta acumulada a partir del segundo n�mero
                for (int i = 1; i < numeros.Count; i++)
                {
                    resultado -= numeros[i];
                }

                // Borrar el Entry y mostrar el resultado
                EntradaCalculadora.Text = resultado.ToString();

                // Reiniciar la lista de n�meros y el estado
                numeros.Clear();
                restando = false;
            }
        }

        if (multiplicando)
        {
            // A�adir el �ltimo n�mero despu�s del s�mbolo "*"
            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
            {
                numeros.Add(ultimoNumero);  // A�adir el �ltimo n�mero a la lista

                // Realizar la multiplicaci�n acumulada
                int resultado = 1;  // Empezamos con 1 porque vamos a multiplicar

                foreach (int num in numeros)
                {
                    resultado *= num;
                }

                // Borrar el Entry y mostrar el resultado
                EntradaCalculadora.Text = resultado.ToString();

                // Reiniciar la lista de n�meros y el estado
                numeros.Clear();
                multiplicando = false;
            }
        }

        if (dividiendo)
        {
            // A�adir el �ltimo n�mero despu�s del s�mbolo "�"
            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
            {
                numeros.Add(ultimoNumero);  // A�adir el �ltimo n�mero a la lista

                // Inicializar el resultado con el primer n�mero de la lista
                int resultado = numeros[0];

                // Realizar la divisi�n acumulada a partir del segundo n�mero
                for (int i = 1; i < numeros.Count; i++)
                {
                    if (numeros[i] == 0)
                    {
                        // Mostrar un mensaje de error si se intenta dividir por cero
                        EntradaCalculadora.Text = "Error: Divisi�n por 0";
                        numeros.Clear();
                        dividiendo = false;
                        return;  // Salir de la operaci�n
                    }

                    resultado /= numeros[i];
                }

                // Borrar el Entry y mostrar el resultado
                EntradaCalculadora.Text = resultado.ToString();

                // Reiniciar la lista de n�meros y el estado
                numeros.Clear();
                dividiendo = false;
            }
        }

        if (porcentaje)
        {
            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
            {
                // A�adir el �ltimo n�mero a la lista
                numeros.Add(ultimoNumero);

                // Si hay m�s de un n�mero, calculamos el porcentaje
                if (numeros.Count > 1)
                {
                    // El primer n�mero es la base para el porcentaje
                    int baseNumero = numeros[0];
                    int porcentajeNumero = numeros[1]; // El segundo n�mero es el porcentaje a calcular
                                                       // Calcular el porcentaje
                    double resultado = (baseNumero * porcentajeNumero) / 100.0; // Realizar el c�lculo
                    EntradaCalculadora.Text = resultado.ToString();
                }
                else
                {
                    // Si solo hay un n�mero, simplemente muestra su valor en porcentaje
                    EntradaCalculadora.Text = (ultimoNumero / 100.0).ToString();
                }
                numeros.Clear();
                porcentaje = false; // Reiniciar el estado
            }
        }
    }
    #endregion
}