   M S B A M L   `   `   `  ����B  >Jupiter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Jupiter.Views.ModalJupiter.Views.Modal  5      (    "Jupiter.Views.Modal.ModalPagamento   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Jupiter.Views.Modal     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  ModalPagamento��5	      $	��300��5
      $	��400��5       � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      ��5      Z� .��5      #  MaterialDesignThemes.Wpf.Card  -   5        $
��View��5   	   $��Stretch=�5   	   $��Stretch=�5   	   .��5   
   � .+�5      �� $��40��5      $��Stretch=�5      $	��Top=�5      
���   �
����� �$��0,0,0,1q�5      ._�5      � .+�5      �� -   5        $��	btn_close��5       $��40��5!      $
��10,0q�5"      $��4q�5#      $��Right=�5$      
����� ����	#DDFFFFFF��5%      Z� .��5)      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�62   5*      �� 5+      -   5        $��Titulo��5,      $��Center=�5-      $��Center=�5.      
�������Novo Pagamento51      52      53      �� 55      $	��200��56      $��0,20,0,0q�57      $��Center=�58      $��Center=�59      .+�5:      �� -   5        $��_titulom��5;      $��Center=�5<      $��10(�5=      
�������Mês a pagar5@      �� 5A      -   5        $��
displayMes��5B      $��0,0,0,3q�5C      $��Center=�5D      $��20(�5E      �� 5F      $��0,0,0,10q�6   .+�5G      �� $��Center=�5H      $��13(�5I      
��������� 5K      $�Propina:��6    �� 5L      -   5         �Name$ _p��5L      5M      �� 5O      $��Center=�5P      $��13(�5Q      
��������� 5S      $�Multa:��6    �� 5T      -   5        $ _m��5T      5U      5W      �� 5X      -   5        $��_meses��5Y      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 MÊS��5Z         
IsFloating .  �� SelectedIndex$ 0��5\      ��5^      �� 5_      .R�5`      �� ��6(   �� *Nome+5a      5c      �� 5d      -	   5        $��_TipoPagaemnto��5e      $��0,10,0,0q�5f      $ FORMA DE PAGAMENTO��5g       . $ 0��5i      .@�5k      �� .��6#   
DINHEIRO5m      �� 5n      .��6#   TRANSFERÊNCIA5p      5q      �� 5r      -
   5        $��propina��5s      $
��0,10q�5t      $ Valor da Propina��5u       . $��0��5y      5z      � 5{      .+�5|      �� -   5        $��Multa��5}      $ Valor da Multa��5~       . $��0��5�      5�      �� 5�      -   5        $	��dvm��5�      $
��10,0q�5�      $��Right=�5�      ���	#FFD40000���	#FFD40000
���   �5�      5�      �� 5�      -   5        $��
btn_Action��5�      $��0,20,0,0q�5�      $��Center=�5�      $��12(�5�      .��6#   	Adicionar5�      5�      5�      5�      5�      