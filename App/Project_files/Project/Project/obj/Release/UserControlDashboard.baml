   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf "    Project.UserControlDashboard   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Project     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  -   $6��0/Project;component/Fonts/#Champagne & Limousines)�
�������.���   � RowDefinitions  �� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $	��250 ��� $��* ��� $	��350 �.+�� $��2��$��0��$��3��.+��� $��15q����	#FF009CDE$��80��$	��Top=�.+��� $��Общая сумма��$��18(�$
��10 5q�$
��Left=�
��������� -    ��Name$ TextBlockTotal��$��UZS 0,00��$
��10 0q�$��22(�$��Right=�
�������� ���	#FFB8DDEE$��15 100 15 15q�.+��� $��История��$��16(�$��10q�$
��Left=��� -    ��Name$ ListViewTimeLine��$��0 40 0 0q����#abcdef���� *ItemTimeLine+����  �� 
TargetType" ��.���  �� Property � |� �� Value .  ���� .R���  �� Orientation$ 
Horizontal=�.+��� $��50��$��5q�$��Center=�
�������$��14(�$
��Bold"�����  �� Path$
 Date�	 �� StringFormat$	 
{0:dd-MMM}��� $
��10 0q�.+��� ���	#FF009CDE$��Center=�$��2��$��	0 9.7 0 0q�� $	��Top=�.+�A� $��22��$��22�����	#FF009CDE$��Center=�$��Center=�$��1��A� $��16��$��16�����	#FF009CDE$��Center=�$��Center=�$��2��A� $��6��$��6�����	#FF009CDE$��Center=�$��Center=�� $	��180��.+��� $��Center=�.+��� $��	5 10 10 0q�$6��0/Project;component/Fonts/#Champagne & Limousines)�$��18(�
 �� TextAlignment$

 Left=����� $
 Type��� $��5q�$6��0/Project;component/Fonts/#Champagne & Limousines)�$��14(�$

 Left=����	#FF009CDE���� $ Description��� $��5q�$6��0/Project;component/Fonts/#Champagne & Limousines)�$��18(�$
��Bold"�$

 Left=����� $ Value����� $ Brush��� $��1��$��3��$	��150��$
��5 15q����	#FFABDDF9.���� .+��� ���#fffdd0$��15q�.+��� $��Расходы��$��20 10q�$��18(��� -    ��Name$  TextBlockCategoryCostEmpty��$+��%Здесь еще ничего нет��$��20q�$��24(�$��Center=�$��Center=��� $��Visible=�$��Disabled=�.���� -    ��Name$ StackCategoryCost��$ 
Horizontal=�$	��Top=��� 
�������$��1��$��20 0 5 0q��� ���	#FFE4F09B$��1��$��20 0 5 0q��� ���#fffdd0$��15q� J� RenderTransformOrigin$ 0.483,1.609&�.+��� $/��)ЕЖЕМЕСЯЧНАЯ ДИАГРАММА��$��20 10q�$��18(��� -   $! TextBlockMonthlyChartsEmpty��$+��%Здесь еще ничего нет��$��20q�$��24(�$��Center=�$��Center=��� $��Visible=�$��Disabled=�.���� -   $ StackMonthlyChart��$ 
Horizontal=�$	��Top=��� 
�������$��1��$��20 0 5 0q��� ���#fffdd0$��15q�.+��� $'��!ЕЖЕМЕСЯЧНЫЙ ДОХОД��$��20 10q�$��18(��� -   $! TextBlockMonthlyIncomeEmpty��$+��%Здесь еще ничего нет��$��20q�$��24(�$��Center=�$��Center=��� $��Visible=�$��Disabled=�.���� -	   $ StackMonthlyIncome��$ 
Horizontal=�$	��Top=�� $��0��$��0��$��3��.+�� $��15q����#d8bfd8  �� $��40 ��� $
��181* �.+��� $��Профили��$��16(�$��10q�$
��Left=�$��0���� -
   $ ListViewAccounts��$��1������ *	Account+���� " ��.���  � |� .  ���� .R��� $	��185������ $
 Name�.��� .+���  ��Language$ pt-BR�$��5q�$6��0/Project;component/Fonts/#Champagne & Limousines)�$��15(�$
 Right=�$��Right=����� $ Amount�$	 {0:C}��