   M S B A M L   `   `   `  ����D  @Example01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Example01	Example01  5   	       Example01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Example01     5   	     � Title$  	第一章��5   	   $	��600��6   $	��800��6"   ���	#FFF0F9D8 � WindowStartupLocation$ CenterScreen=�5	       .��5
      � $��20q�6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5      $��* �6   6+   .+�5   
   �� $��2��6   
������� �� RadiusX$ 14��5       �� RadiusY$ 14��6!   
����  � �� StrokeDashArray$ 3R�6<   �� 5   
   $��0��6   $��7q�6$   ���	#FFF0F9D8$ 10��5      $ 10��6!   
����  �$ 3R�6<   �� 5   
   $��0��6   $��20q�6$   
�������
����  �5      �� 5   
   $��0��6   $��22q�6'   .��5      ��  � 	Resources 5       �� 
TargetType �� Property	 �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$	 Center=�6G   �� 5       � ��$	 5 10 5 0q�63   �� 5       � ��$	 	15 0 15 0q�64   �� 5       � ��$	 10(�65   -   5        5      5      .+�5       �� -   5        

 � Tag$
 /Exam/Page1.xaml��5       .��6E   例一6I   �� 5!      -   5        $
 /Exam/Page2.xaml��5!      .��6E   例二6I   �� 5"      -   5        $
 /Exam/Page3.xaml��5"      .��6E   例三6I   5#      5$       � 5%   
   -   5          �Name$	 frm��5%      $��1��6   $��10q�6-   $��1q�69   
����  �  � NavigationUIVisibility$ Hidden=�5&   #   5.      5/      