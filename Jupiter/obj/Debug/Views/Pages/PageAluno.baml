   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.PagesJupiter.Views.Pages  5      #    Jupiter.Views.Pages.PageAluno   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Pages     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $	��850��5
      $	��530��5      $��Stretch=�5      $��Stretch=�5        � Language$  pt-PT�5       N� Title 5	      �� *Nome+.��5      � -   5        $��gridM��5      
�������.+�5   
   �� $	��250��5      $��Stretch=�5      $	��Top=�5       J� RenderTransformOrigin$ 0.5,0.5&�5      ��5      �� 5       �� ImageSource$&  /Jupiter;component/Assets/tr.jpg��6    j� Stretch$ UniformToFill=�6L    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterX$	 0.5Q�5   !    �� CenterY$	 0.5Q�5   !    �� ScaleX$ -1Q�5   !   	 �� ScaleY$	 1Q�5   !   �� 5      
 �� AngleX$
 0Q�6,    �� AngleY$ 0Q�67    �� CenterX$	 0.5Q�6B    �� CenterY$	 0.5Q�6P   �� 5        �� Angle$ 0Q�6.    �� CenterX$	 0.5Q�68    �� CenterY$	 0.5Q�6F   T� 5!      5"      5$      ._�5&      � .+�5'      � ���	#660000006   �� 5)      $��	80,30,0,0q�6   $
��Left=�60   .+�5+      ��  �� Orientation$ 
Horizontal=�6!   .+�5,      �� $��13(�5-      $
��Bold"�5.      
�������ID:51      �� 52      $	��5,0q�53      $��14(�54      $
��Bold"�55      
���������57      �� *ID+58      �� 59      $
��0,10q�6!   $ 
Horizontal=�6/   .+�5:      �� 
�������Nº:5<      �� 5=      $	��5,0q�5>      
���������5@      �� *Numero+5A      �� 5C      $��0,0,0,10q�6!   $ 
Horizontal=�63   .+�5D      �� 
�������	Classe:5F      �� 5G      $	��5,0q�5H      
���������5J      �� *Classe+5K      �� 5M      $��0q�6!   $ 
Horizontal=�6,   .+�5N      �� 
�������Sala:5P      �� 5Q      $	��5,0q�5R      
���������5T      �� *Sala+5U      �� 5W      $
��0,10q�6!   $ 
Horizontal=�6/   .+�5X      �� 
�������Turma:5Z      �� 5[      $	��5,0q�5\      
���������5^      �� *Turma+5_      �� 5a      $��0q�6!   $ 
Horizontal=�6,   .+�5b      �� 
�������Ano:5d      �� 5e      $	��5,0q�5f      
���������5h      �� *Ano+5i      �� 5k      $
��0,10q�6!   $ 
Horizontal=�6/   .+�5l      �� 
�������Data:5n      �� 5o      $	��5,0q�5p      
���������5r      �� *Criado+ �� StringFormat$ d��5s      5t      �� 5u      .+�5v      �� $	��135��5w      $	��135��5x      $��	0,20,0,10q�5y      $��Center=�5z      
������� &  "MaterialDesignFloatingActionButton#���   5|      ��5}      �� 5~      $ UniformToFill=�6F    6)   �� *Foto+6F   5�      �� 5�      $	��0,5q�5�      $��Center=�5�      $��16(�5�      
������� �� TextAlignment$ Center=�5�      ��5�      �� *Nome+5�      5�      �� 5�      $��20q�5�      $
��Left=�5�      $	��Top=�5�      $ 
Horizontal=�5�      .+�5�      �� -   5        $��	_btn_Back��5�      
���   �
����������	#DDFFFFFF.��5�      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowBack=�62   5�      5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�      $��20q�5�      $��Right=�5�      $	��Top=�5�      
�������
�������   PopupContent. 5�      �� .+�5�      m� -   5        $��_Editar��5�      $��Editar��5�       m� Icon 5�        5�   "   $ UserEdit=�6:   5�      m� 5�      -   5        $��	gerarCard��5�      $��Gerar Cartão��5�       5�        5�   "   $ CardBulleted=�6:   5�      m� 5�      -   5        $��	PrintCode��5�      $��Imprimir Código de Barra��5�       5�        5�   "   $ Barcode=�6:   5�      m� 5�      -   5        $��AnoNovo��5�      $��Novo Ano Letivo��5�       5�        5�   "   $ Class=�6:   5�      �� 5�      m� 5�      -   5        $��Eliminar Aluno��5�   :    5�        5�   "   ���	#FFFF0404$ Delete=�6Q   5�      5�      5�      5�      5�      �� 5�   
   $	��275��5�      $��20,255,20,0q�5�      
������ ���	#FFF1F1F1 �� CornerRadius$ 5��5�      ._�5�      &   System.Windows.Controls.DataGrid  -   5        $��_ListaPagamentos��5�      $��Stretch=�5�      -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�5�         ColumnHeaderPadding$ 8q�5�         AutoGenerateColumns .  
�������   CanUserAddRows .     CanUserSortColumns .    Columns 5�      9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 MÊS��5�         
IsReadOnly . $
��Bold"�5�      1  +System.Windows.Controls.DataGridBoundColumn    Binding  5�      �� *Data+$
 MMMM��5�        5�      $ PROPINA��5�       .   5�      �� *	Propina+$ C��! �� ConverterCulture$! pt-AO��5�        5�      $ MULTA��5�       .   5�      �� *	MultaInfo+$ C��$! pt-AO��5�        5�      $ TOTAL��5�       .   5�      �� *Total+$ C��$! pt-AO��5�        5�      $ FORMA DE PAGAMENTO��5�       .   5�      �� *
TipoInfo+5�        5�      $ DATA DE PAGAMENTO��5�       .   5�      �� *Criado+$ D��5�      5�      5�      �� 5�   
   $��30q�5�      $��Right=�5�      $��Bottom=�5�      $ 
Horizontal=�5�      .+�5�      �� -	   5        $��btn_add_Pagamento��5�      $��40��5�      $��40��5      $	��5,0q�5     ���	#FF1B1B1C
�������
�������#���   5     " � ToolTip$" Adicionar Pagamento��5     .��5       $
 Plus=�6*   5	     �� 5     -
   5        $��EdiarP��5     $ 
Horizontal=�5     $y�Visible=�5     .+�5     �� -   5        $��editar��5     $��30��5     $��30��5     $��0q�5     ���	#FF00FB17
�������
�������#���   5     $" Editar Pagamento��5     $y�	Collapsed=�5     .��5       $
 Edit=�6.   5     �� 5     -   5        $��recibo��5     $��40��5      $��40��5!     $	��5,0q�5"     
���   �
�������
�������#���   5'     $" Recibo do Pagamento��5(     $y�	Collapsed=�5)     .��5*       $ FilePdf=�6.   5+     �� 5,     -   5        $
��dell��5-     $��30��5.     $��30��5/     $	��5,0q�50     ���	#FFFB0000
�������
�������#���   55     $" Apagar Pagamento��56     $y�	Collapsed=�57     .��58       $ Delete=�6.   59     5:     5;     �� 5<  
   -   5        $��gerar_Pagamento��5=     $��40��5>     $��30��5?     $��
0,210,20,0q�5@     $��4q�5A     $��Right=�5B     $	��Top=�5C     
���   �
�������
�������$%" Relatório dos Pagamento feitos��5H     .��5I       $ FilePdf=�6&   5J     � 5K  
   -   5        $��HideView��5L     ���	#19000000$y�	Collapsed=�5N     5O     5P     