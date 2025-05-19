using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Entity;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace BLL
{
    public class CitaPdf : IDocument
    {

        
        public CitaPdf(Cita cita,Paciente paciente,Doctor doctor,EspecialidadCita especialidadCita)
        {
            Cita = cita;
            Paciente = paciente;
            Doctor = doctor;
            EspecialidadCita = especialidadCita;
        }

        public Cita Cita { get; }
        public Paciente Paciente { get; }
        public Doctor Doctor { get; }
        public EspecialidadCita EspecialidadCita { get; }

        public void Compose(IDocumentContainer container)
        {
            container.Page(pagina =>
            {
                pagina.Margin(50);
                pagina.Header().Element(ConstruirCabecera);
                pagina.Content().Element(ConstruirContenido);
            });
        }

        private void ConstruirContenido(IContainer contenedor)
        {
            contenedor.PaddingVertical(40).Column(column =>
            {
                column.Item().Element(ConstruirContenidoCita);
                column.Item().Text(Cita.MotivoCita.ToString());
                column.Item().Text(Cita.Observaciones.ToString());
            });
        }

        private void ConstruirContenidoCita(IContainer contenedor)
        {
            contenedor.Table(table =>
            {
               table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(2);
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(1);
                    columns.RelativeColumn(1);
                });

                table.Header(cabecera =>
                {
                    cabecera.Cell().Element(EstiloCelda).Text("Doctor");
                    cabecera.Cell().Element(EstiloCelda).AlignRight().Text("Fecha de la cita");
                    cabecera.Cell().Element(EstiloCelda).AlignRight().Text("Hora de la cita");
                    cabecera.Cell().Element(EstiloCelda).AlignRight().Text("Estado");
                    cabecera.Cell().Element(EstiloCelda).AlignRight().Text("Especialidad");


                    static IContainer EstiloCelda(IContainer celda)
                    {
                        return celda.DefaultTextStyle(x => x.SemiBold())
                            .PaddingVertical(5)
                            .BorderBottom(1)
                            .BorderColor(Colors.Black)
                            ;
                    }
                });

                

                
                    table.Cell().Element(EstiloCelda).Text(Doctor.Nombre + " " +Doctor.Apellido);
                    table.Cell().Element(EstiloCelda).AlignRight().Text(Cita.FechaCita.ToString("dd/MM/yyyy"));
                    table.Cell().Element(EstiloCelda).AlignRight().Text(DateTime.Parse(Cita.HoraCita).ToString("HH:mm:ss"));
                    table.Cell().Element(EstiloCelda).AlignRight().Text(Cita.EstadoCita);
                    table.Cell().Element(EstiloCelda).AlignRight().Text(EspecialidadCita.nombre);
                
                    static IContainer EstiloCelda (IContainer contenedor)
                {
                    return contenedor.DefaultTextStyle(x => x.SemiBold())
                        .PaddingVertical(5)
                        .BorderBottom(1)
                        .BorderColor(Colors.Black);
                }


            });
        }

        private void ConstruirCabecera(IContainer contenedor)
        {
            contenedor.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {

                    column.Item().Text("MEDICORE").FontSize(20).Bold();
                    column.Item().Text("Sistema de gestión de citas médicas").FontSize(12).Bold();
                    column.Item().Text("Citas Medicas").FontSize(12).Bold();
                    column.Item().Text(" ");
                    column.Item().Text("-----------------------------------------------");
                    column.Item().Text(" ");
                    column.Item().Text("Fecha de emision: " + DateTime.Today.ToString("dd/MM/yyyy")).FontSize(12);
                    column.Item().Text("Hora de emision: " + DateTime.Now.ToString("HH:mm:ss")).FontSize(12);
                });

                row.RelativeItem().Border(1).Column(column =>
                {

                    var padding = 5;
                    column.Item().BorderBottom(1).Padding(padding).Text("Comprobante de cita").SemiBold();
                    column.Item().Padding(padding).Text("ID Cita: " + Cita.IdCita.ToString()).FontSize(12);
                    column.Item().Padding(padding).Text("nombre del paciente: " + Paciente.Nombre.ToString() + "  " + Paciente.Apellido).FontSize(12);
                    column.Item().Padding(padding).Text("Fecha de venncimiento del comprobante: " + Cita.FechaCita.ToString("dd/MM/yyyy")).FontSize(12);

                    
                });


                
            });
        }

        
    }
}
