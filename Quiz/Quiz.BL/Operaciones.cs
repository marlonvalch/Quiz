using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.DAL;

namespace Quiz.BL
{
   public class Operaciones
    {
        public void AgregarDatos(Datos_Personales listaDatos)

        {
            
            using (RegistrosEntities context = new RegistrosEntities())
            {
                try
                {
                    context.Datos_Personales.Add(listaDatos);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("e BL.AgregarDatos");
                }
            }
        }

        public void AgregarDirecciones(Direcciones listaDirecciones)

        {

            using (RegistrosEntities context = new RegistrosEntities())
            {
                try
                {
                    context.Direcciones.Add(listaDirecciones);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("e BL.AgregarDirecciones");
                }
            }
        }

        ///////////////Eliminar//////////////////////////////
        

        public void EliminarDatos(int ID)
        {
            using (RegistrosEntities context = new RegistrosEntities())
            {
                try
                {
                   var Datos_Personales = context.Datos_Personales.Where(x => x.id_Persona == ID).SingleOrDefault();
                    context.Datos_Personales.Remove(Datos_Personales);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("e BL.EliminarDatos");
                }
            }
        }

        public void EliminarDirecciones(int ID)
        {
            using (RegistrosEntities context = new RegistrosEntities())
            {
                try
                {
                    var Direcciones = context.Direcciones.Where(x => x.id == ID).SingleOrDefault();
                    context.Direcciones.Remove(Direcciones);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("e BL.EliminarDirecciones");
                }
            }
        }

        ///////////////Mostrar//////////////////////////////

        public List<Datos_Personales> MostrarDatos()
        {

            Datos_Personales  Datos 
            using (RegistrosEntities context = new RegistrosEntities())
            {
                try
                {
                    context.Datos_Personales.All(Datos_Personales);
                    context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine("e BL.EliminarDirecciones");
                }
            }
            return context.all
        }



    }


}





    

