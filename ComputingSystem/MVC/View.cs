using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingSystem.MVC
{
    abstract class View : IDisposable
    {
        public View(Model model, Controller controller)
        {
            this.model = model;
            this.controller = controller;
        }

        public readonly Model model;
        public Controller controller
        {
            private get;
            set;
        }
        public void ReactToUserActions(ModelOperations modelOperation)
        {
            controller.Execute(modelOperation, model);
        }
        public void Dispose()
        {
            DataUnbind();
        }
        abstract public void DataBind();
        abstract public void DataUnbind();
    }
    enum ModelOperations
    {
        // Сохранение настроек
        SaveSettings,
        // Рабочий такт
        WorkingCycle,
        // Завершение сеанса
        EndOfSession
    }

}
