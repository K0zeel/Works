   M S B A M L   `   `   `  ����E  APractWork6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PractWork6
PractWork6  5   	       PractWork6.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PractWork6     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	        PractWork6.Game  5
   
   .��5      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ GameDataGrid��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ IdGame��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *IdGame+  5      $
 Name��6%    63   �� *Name+  5      $ Description��6%    6:   �� *Description+  5      $ Category��6%    67   �� *
Category+  5      $ Price��6%    64   �� *Price+5      �� 5   
   .+�5      �� $��IdGame��6   �� 5      -   5         ��Name$ 	idTextBox��5      ��6)   �� *SelectedItem.IdGame+	 �� ElementName$	 GameDataGrid��
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $
��Name��6   �� 5      -   5        $ nameTextBox��5      ��6+   �� *SelectedItem.Name+$	 GameDataGrid��$
 TwoWay=�$ PropertyChanged=��� 5!      $��Description��6   �� 5"      -   5        $ descriptionTextBox��5"      ��62   �� *SelectedItem.Description+$	 GameDataGrid��$
 TwoWay=�$ PropertyChanged=��� 5&      $��Price��6   �� 5'      -   5        $ priceTextBox��5'      ��6,   �� *SelectedItem.Price+$	 GameDataGrid��$
 TwoWay=�$ PropertyChanged=��� 5+      $��Category��6   �� 5,      -   5         ��Name$ categoryComboBox��5,       �� SelectedItem 61   �� *SelectedItem.Category+$	 GameDataGrid��$
 TwoWay=�$ PropertyChanged=���50      �� 51       �� DataType$ local:Category��6#   .R�52      �� ��6'   �� *NameCategory+53      55      56      57      58      