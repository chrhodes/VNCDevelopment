﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using DevExpress.Xpf.Grid;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace VNC.Core.Presentation.ViewModels
{
    public class ExportGridDialogViewModel : BindableBase, IDialogAware
    {
        #region Constructors, Initialization, and Load


        #endregion

        #region Enums (none)


        #endregion

        #region Structures (none)


        #endregion

        #region Fields and Properties

        public event Action<IDialogResult> RequestClose;

        private DelegateCommand<string> _closeDialogCommand;
        public DelegateCommand<string> CloseDialogCommand =>
            _closeDialogCommand ?? (_closeDialogCommand = new DelegateCommand<string>(CloseDialog));

        private GridControl _activeGridControl = null;

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _cancelContent = "Cancel";
        public string CancelContent
        {
            get { return _cancelContent; }
            set { SetProperty(ref _cancelContent, value); }
        }

        private string _okContent = "Save";
        public string OKContent
        {
            get { return _okContent; }
            set { SetProperty(ref _okContent, value); }
        }

        private string _title = "Save Grid";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _outputFileNameAndPath = @"C:\temp\GridExport";
        public string OutputFileNameAndPath
        {
            get => _outputFileNameAndPath;
            set
            {
                if (_outputFileNameAndPath == value)
                    return;
                _outputFileNameAndPath = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<string> FileFormats { get; set; }

        private List<string> _selectedFileFormats;
        public List<string> SelectedFileFormats
        {
            get => _selectedFileFormats;
            set
            {
                if (_selectedFileFormats == value)
                    return;
                _selectedFileFormats = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Event Handlers (none)

        public virtual void OnDialogClosed()
        {

        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            if (parameters.ContainsKey("outputfilenameandpath"))
            {
                OutputFileNameAndPath = parameters.GetValue<string>("outputfilenameandpath");
            }

            if (parameters.ContainsKey("gridcontrol"))
            {
                _activeGridControl = parameters.GetValue<GridControl>("gridcontrol");
            }
            else
            {

            }
        }

        #endregion

        #region Commands (none)

        #endregion

        #region Public Methods

        protected virtual void CloseDialog(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
            {
                result = ButtonResult.OK;

                foreach (var fileFormat in SelectedFileFormats)
                {
                    switch (fileFormat)
                    {
                        // TODO(crhodes)
                        // Figure out package dependencies to make this work.
                        case ".docx":
                            _activeGridControl.View.ExportToDocx($"{OutputFileNameAndPath}{fileFormat}");
                            break;

                        case ".html":
                            _activeGridControl.View.ExportToHtml($"{OutputFileNameAndPath}{fileFormat}");
                            break;

                        case ".pdf":
                            _activeGridControl.View.ExportToPdf($"{OutputFileNameAndPath}{fileFormat}");
                            break;

                        case ".xlsx":
                            _activeGridControl.View.ExportToXlsx($"{OutputFileNameAndPath}{fileFormat}");
                            break;
                    }
                }
            }
            else if (parameter?.ToLower() == "false")
                result = ButtonResult.Cancel;

            RaiseRequestClose(new DialogResult(result));
        }

        public virtual Boolean CanCloseDialog()
        {
            return true;
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }

        #endregion

        #region Protected Methods (none)


        #endregion

        #region Private Methods (none)


        #endregion
    }
}