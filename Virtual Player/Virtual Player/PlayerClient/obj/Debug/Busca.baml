   M S B A M L   `   `   `  ����G  CPlayerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PlayerClientPlayerClient  5          PlayerClient.Busca   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:PlayerClient     5        N� Title$  Vurtual Player - Busca��5	      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��100 �6   �� 5      $��50 �6     � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��txtNomeBusca��5   V   $��0��6   $��0��6"   $��2��6/   $��	5,10,10,0q�6C   6l   �� 5   
   -   5        $��btnBusca��5   K   $��2��6   $��0��6!   $��50��6.   $��0,10,0,0q�69   .��6r   OK6v   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
grdMusicas��5   G   $��3��6   $��1��6'   $��	5,10,0,10q�64      AutoGenerateColumns .     CanUserAddRows .     ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *CaminhoMusica+6]     5      
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 385 6%      Header$ Música��61   	 6A   �� *
NomeMusica+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 50 6)      CellTemplate 5       �� 5!      .R�5"      �� $��btnPlay��6%   -   5        .��5"   J   PLAY6P   5#      5%      5'      5(      5)      