   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject      Project.UserIncome   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Project     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $2��,/Project;component/Fonts/#EngraversGothic BT)�.��� .+��� $	��120�����#177245$	��Top=�.+��� $��Доходы��$��24(�$
��Bold"�$��	20 20 0 0q��� -     ��Name$  TextBlockTotal��$��UZS 0,00��$��22(�$
��20 0q���  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ TextBoxValue��$	��113��$��15q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Сумма��$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ DatePickerData��$	��103��$ Дата��$��Center=�$��15q��� -    ��Name$ ComboBoxCategory��$	��158��$��15q�$ Категория��$��Center=� �� 
GroupStyle (  "System.Windows.Controls.GroupStyle     HeaderTemplate �� .R��� $	��5 0q����� *Name+���� .R��� ���� *Name+�� -   $ ComboBoxAccounts��$	��117��$��15q�$! Учетная запись��$��Center=����� .R��� $ 
Horizontal=�.+��� $	��400������  �� Path$
 Name��� -   $ ComboBoxComment��$	��237��$ Комментарий��$��Center=�$��15q��� -   	 ��Name$	 ButtonAddIncoming��$��Right=�$��Center=�.��'  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Check=�� $��	0 120 0 0q�.+��� $ 
Horizontal=�$��Center=�$	��Top=�$��5q�.+��� -	   $	 ButtonPreviousMonth��$��5q�.��  $
 	ArrowLeft=�� $��90��.+��� -
   $  TextBlockYear��$
��2023��$��Center=�$	��Top=�$��5q�$��15(��� -   $  TextBlockMonth��$��Май��$��18(�$��Bottom=� �� TextAlignment$ Center=�$��5q��� -   $	 ButtonNextMonth��$��5q�.��  $
 
ArrowRight=��� -    ��Name$ ListViewTransactions��$��18(�$��0 50 0 0q�����  �� 
TargetType" ��.���  �� Property � |� �� Value .  ���� .R��� $ 
Horizontal=�.+��� $	��300��$��10q�$��Center=����� $ Description��� $	��300��$��10q�$��Center=�$��CharacterEllipsis=����� $ Category���  ��Language$ pt-BR�$��10q�$��Center=����� $
 Date� �� StringFormat$ {0:d}���� $ pt-BR�$	��300��$ Right=�$��10q�$��Center=����� $ Value�$ {0:C}���� $	��500��$��10q�$��Center=����� $ Comment��� $	 
ButtonEdit��-   $��25 0 5 0q�$��60��.��  $
 Pencil=��� $	 ButtonDelete��-   $	��5 0q�$��60��.��  $
 Delete=��� -   $  TextBlockIncomingsEmpty��$+��%Здесь еще ничего нет��$��24(�$��Center=�$��Center=�'  !MaterialDesignThemes.Wpf.Snackbar  -     Name$ SnackbarThree��$��15q�   MessageQueue 4  .MaterialDesignThemes.Wpf.MessageQueueExtension  