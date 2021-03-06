using System.ComponentModel.Composition;
using Balakin.VSOutputEnhancer.Logic;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Balakin.VSOutputEnhancer.UI.FormatDefinitions
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationType.NpmMessageError)]
    [Name(ClassificationType.NpmMessageError)]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    public sealed class NpmMessageErrorFormatDefinition : StyledClassificationFormatDefinition
    {
        [ImportingConstructor]
        public NpmMessageErrorFormatDefinition(IStyleManager styleManager) : base(styleManager)
        {
        }
    }
}