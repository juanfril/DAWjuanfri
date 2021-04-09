# Ejemplo de bucle for
BEGIN { FS = ";" }
{
    for (i = 1; i <= $5; i++) 
        printf "%d unidades de %s cuestan: %.2f€\n", i, $3,($4*i)
}
