   M S B A M L   `   `   `  ����B  >girisii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:girisiigirisii  5   	       girisii.AnaEkran   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:girisii  5   	     � WindowStyle$
  None=�5   	    � Title$ AnaEkran��5
   	   $	��609��6   $
��1080��6'    � 
ResizeMode$ NoResize=�64    � Icon$ icons/literature.png��6J   
������� � WindowStartupLocation$ CenterScreen=�6y    � 	Resources 5       
  MenuAc �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	Menukapat��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 70Q�63     5      $ 0:0:0.5��6'   $		 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $		 200Q�63     5      $ 0:0:0.5��6'   $	 70Q�69   5      5      5      
 � Triggers
 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ 	butonacma��66   .[�5      �� #��[  6   5      :� 5   
   $ ButtonBase.Click��6   $ butonkapatma��66   .[�5      �� #��[ 6   5      .��5!      � ���	#FF23202B.+�5"   
   � $��60��6   $	��Top=�6   ���	#FF4B357D.+�5#      �� $��Kütüphane Otomasyonu��6   $��Center=�64   $��Center=�6Q   $��22(�6l   �� 5$      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5%      �� $��Seçenekler��6   $��Center=�6.   $��18(�6I   '  !MaterialDesignThemes.Wpf.PopupBox  5&      $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen .     PopupContent. 5'      �� $	��150��6!   .+�5(      �� -   5         ��Name$	 dil��5(   !   $	��Dil��6.   �� 5)      �� 5*      -   5        $ CıkısyapButon��5*   !   $��Çıkış Yap��68   6L   5+      5,      5-      5.      � 5/   
   -   5         �Name$ GridMenu��5/      $��60��6!   $
��Left=�6,   ���	#FF4B357D.+�50      �� .+�51      � $	��150��6   ���	#FF4B357D.+�52      �� -   5        $ butonkapatma��52      $��60��63   $��60��6>   $	��Top=�6w   $��Right=�6�   $y�	Collapsed=�6�   ��6J   Z� ��6`   Z� .��53      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$ 	ArrowLeft=�6E   $��25��6V   $��25��6a   54      �� 55      -   5        $ 	butonacma��55      $��60��60   $��60��6;   $	��Top=�6t   $��Center=�6�   ��6G   Z� ��6]   Z� .��56        
�������$
 Menu=�6E   $��25��6Q   $��25��6\   57      58      �� 59      $��Disabled=�6   
���   �.@�5:      �� -   5         ��Name$ Kiekle��5:   #   $��60��63   .��5;      �� -   5        $ 
Horizontal=�5;   %   .+�5<        $ BookAdd=�66   $��25��6E   $��25��6P   $��10q�6\   $��Center=�6h   
�������6�   �� 5=      $��
Kitap Ekle��6(   $��Center=�6:   $��20 10q�6U   
�������6d   5>      5?      �� 5@      $��60��6#   .��5A      �� -   5        $ 
Horizontal=�5A   %   .+�5B        $
 User=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   
�������6�   �� 5C      $��Üyeleri Listele��6(   $��Center=�6?   $��20 10q�6Z   
�������6i   5D      5E      �� 5F      $��60��6#   .��5G      �� -	   5        $ 
Horizontal=�5G   %   .+�5H        $ Warning=�66   $��25��6E   $��25��6P   $��10q�6\   $��Center=�6h   
�������6�   �� 5I      $��Gecikmiş Kitaplar��6(   $��Center=�6A   $��20 10q�6\   
�������6k   5J      5K      �� 5L      $��60��6#   .��5M      �� -
   5        $ 
Horizontal=�5M   %   .+�5N        $ AccountClock=�66   $��25��6J   $��25��6U   $��10q�6a   $��Center=�6m   
�������6�   �� 5O      $��Emanet Kitaplar��6(   $��Center=�6?   $��20 10q�6Z   
�������6i   5P      5Q      �� 5R      $��60��6#   .��5S      �� -   5        $ 
Horizontal=�5S   %   .+�5T        $ ClipboardList=�66   $��25��6K   $��25��6V   $��10q�6b   $��Center=�6n   
�������6�   �� 5U      $��Kitapları Listele��6(   $��Center=�6A   $��20 10q�6\   
�������6k   5V      5W      5X      5Y      5Z      5[      5\      