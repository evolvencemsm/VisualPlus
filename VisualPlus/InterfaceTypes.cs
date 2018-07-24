#region Namespace

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using VisualPlus.Enumerators;
using VisualPlus.Localization;
using VisualPlus.Structure;
using VisualPlus.Toolkit.Components;

#endregion

namespace VisualPlus
{
    /// <summary>The IControlBox.</summary>
    public interface IControlBox
    {
        #region Properties

        [Category(PropertyCategory.Behavior)]
        [Description(PropertyDescription.Toggle)]
        bool CloseBox { get; set; }

        [Category(PropertyCategory.Behavior)]
        [Description(PropertyDescription.Toggle)]
        bool HelpButton { get; set; }

        [Category(PropertyCategory.Behavior)]
        [Description(PropertyDescription.Toggle)]
        bool MaximizeBox { get; set; }

        [Category(PropertyCategory.Behavior)]
        [Description(PropertyDescription.Toggle)]
        bool MinimizeBox { get; set; }

        #endregion
    }

    /// <summary>The IThemeManager.</summary>
    public interface IThemeManager
    {
        #region Properties

        /// <summary>The style manager.</summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        StyleManager ThemeManager { get; set; }

        #endregion
    }

    /// <summary>The ITheme supported control.</summary>
    public interface IThemeSupport
    {
        #region Methods

        /// <summary>Update the control theme.</summary>
        /// <param name="theme">The theme to update with.</param>
        void UpdateTheme(Theme theme);

        #endregion
    }

    public interface IInputMethods
    {
        #region Methods

        void AppendText(string text);

        void Clear();

        void ClearUndo();

        void Copy();

        void Cut();

        void DeselectAll();

        int GetCharFromPosition(Point pt);

        int GetCharIndexFromPosition(Point pt);

        int GetFirstCharIndexFromLine(int lineNumber);

        int GetLineFromCharIndex(int index);

        Point GetPositionFromCharIndex(int index);

        void Paste();

        void ScrollToCaret();

        void Select(int start, int length);

        void SelectAll();

        void Undo();

        #endregion
    }

    public interface IAnimationSupport
    {
        #region Properties

        [DefaultValue(Settings.DefaultValue.Animation)]
        [Category(PropertyCategory.Behavior)]
        [Description(PropertyDescription.Animation)]
        bool Animation { get; set; }

        #endregion

        #region Methods

        /// <summary>Configures the animation settings.</summary>
        /// <param name="effectIncrement">The effect Increment.</param>
        /// <param name="effectType">The effect Type.</param>
        void ConfigureAnimation(double[] effectIncrement, EffectType[] effectType);

        /// <summary>Draws the animation on the graphics.</summary>
        /// <param name="graphics">The specified graphics to draw on.</param>
        void DrawAnimation(Graphics graphics);

        #endregion
    }

    /// <summary> The IMessageBox interface.</summary>
    public interface IMessageBox
    {
        #region Methods

        /// <summary>Displays a message box with the specified text.</summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">Specifies which buttons to display in the message box.</param>
        /// <param name="icon">Specifies which icon to display in the message box.</param>
        /// <returns>The <see cref="DialogResult" />.</returns>
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, Image icon);

        /// <summary>Displays a message box with the specified text.</summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">Specifies which buttons to display in the message box.</param>
        /// <param name="icon">Specifies which icon to display in the message box.</param>
        /// <returns>The <see cref="DialogResult" />.</returns>
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);

        /// <summary>Displays a message box with the specified text.</summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">Specifies which buttons to display in the message box.</param>
        /// <returns>The <see cref="DialogResult" />.</returns>
        DialogResult Show(string text, string caption, MessageBoxButtons buttons);

        /// <summary>Displays a message box with the specified text.</summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <returns>The <see cref="DialogResult" />.</returns>
        DialogResult Show(string text, string caption);

        /// <summary>Displays a message box with the specified text.</summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <returns>The <see cref="DialogResult" />.</returns>
        DialogResult Show(string text);

        #endregion
    }

    /// <summary>The ITextColor.</summary>
    public interface ITextColor
    {
        #region Properties

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        Color Disabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        Color Enabled { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        Color Hover { get; set; }

        [Category(PropertyCategory.Appearance)]
        [Description(PropertyDescription.Color)]
        Color Pressed { get; set; }

        #endregion
    }
}