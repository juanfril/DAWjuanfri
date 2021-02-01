
public class Usuario
{
    private string dni;
    private string nombre;
    private string direccion;
    private string telefono;
    private bool sancionesPendientes;

    // Constructor con todos los parámetros

    public Usuario(string id, string n, string dir,
        string telf, bool sanciones)
    {
        dni = id;
        nombre = n;
        direccion = dir;
        telefono = telf;
        sancionesPendientes = sanciones;
    }

    // Getters y setters

    public string GetDni()
    {
        return dni;
    }

    public void SetDni(string d)
    {
        dni = d;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string n)
    {
        nombre = n;
    }

    public string GetDireccion()
    {
        return direccion;
    }

    public void SetDireccion(string d)
    {
        direccion = d;
    }

    public string GetTelefono()
    {
        return telefono;
    }

    public void SetTelefono(string t)
    {
        telefono = t;
    }

    public bool GetSancionesPendientes()
    {
        return sancionesPendientes;
    }

    public void SetSancionesPendientes(bool s)
    {
        sancionesPendientes = s;
    }
}
