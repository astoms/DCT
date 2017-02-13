using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Общие сведения об этой сборке предоставляются следующим набором
// атрибутов. Отредактируйте значения этих атрибутов, чтобы изменить
// общие сведения об этой сборке.
[assembly: AssemblyTitle("DCT")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("DCT")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Установка значения False в параметре ComVisible делает типы в этой сборке невидимыми
// для COM-компонентов. Если необходим доступ к типу в этой сборке из
// COM, следует установить атрибут ComVisible в TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("20b9dca9-02ed-488b-8736-2b5422f3cdc2")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии
//      Номер построения
//      Редакция
//
[assembly: AssemblyVersion("1.0.0.0")]

// Следующий атрибут служит для подавления предупреждения FxCop "CA2232: Microsoft.Usage: добавьте к сборке STAThreadAttribute",
// так как приложение для устройства не поддерживает поток STA.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")]
