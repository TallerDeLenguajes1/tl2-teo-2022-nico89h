// See https://aka.ms/new-console-template for more information
CajeroAutomatico jose= new CajeroAutomatico();
enum TipoCuenta
{
    CuentaCorrienteEnPesos,
    CuentaCorrienteEnDolares,
    CajaDeAhorroPesos    
}
abstract class Cajero
{
    public Cajero(){
        this.total=213124;
        cuenta= TipoCuenta.CuentaCorrienteEnPesos;
    }
    protected float total;
    protected TipoCuenta cuenta;
    public void insercion( float cantidad){
        //inicio el control de las cantidades
        if (cantidad<=0)
        {
            System.Console.WriteLine("Tenes que colocar una cantidad mayor a 0");
        } else{
            this.total+= cantidad;
        }
    }
    

}

class CajeroAutomatico:Cajero
{

    public float extraccion(float cantidad){
        //inicio el constorl de las cantidades
        if (cantidad<=total && cantidad>0)
        {
            if (cuenta==TipoCuenta.CuentaCorrienteEnPesos) //inicio de corriente en pesos
            {
                //inicio de la clase de cajero automatico
                if (cantidad>=5000 && cantidad<=20000)
                {
                    this.total=this.total-cantidad;
                    return cantidad;
                }else{
                    System.Console.WriteLine("No se puede extraer dicha cantidad");
                    return 0;
                }
            }else if(cuenta==TipoCuenta.CuentaCorrienteEnDolares){
                
                if (cantidad<=200)
                {
                    this.total=this.total-cantidad;
                    return cantidad;
                }else{
                    System.Console.WriteLine("No se puede extraer dicha cantidad");
                    return 0;
                }
            }else{
                if (cantidad<=1000)
                {
                    this.total=this.total-cantidad;
                    return cantidad;
                }else{
                    System.Console.WriteLine("No se puede extraer dicha cantidad");
                    return 0;
                }
            }
        }else
        {
            System.Console.WriteLine("No se puede hacer");
            return 0;
        }
        //return cantidad<=total? cantidad: 0;
    }
     
}
class CajeroHumano:Cajero
{
    public float extraccion(float cantidad){
        //inicio el constorl de las cantidades
        if (cantidad<=total && cantidad>0)
        {
            return cantidad;
        }else
        {
            System.Console.WriteLine("No se puede hacer");
            return 0;
        }
        //return cantidad<=total? cantidad: 0;
    }
}
// class CajeroAutomatico
// {
    
// }
// class Ca
// {
    
// }