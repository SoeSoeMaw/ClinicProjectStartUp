   M S B A M L   `   `   `  ����  ClinicProjectStartUp%    ClinicProjectStartUp.Views.Main   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _DevExpress.Xpf.Ribbon.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon  5      c _DevExpress.Xpf.NavBar.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxn4http://schemas.devexpress.com/winfx/2008/xaml/navbar  5      e aDevExpress.Xpf.Controls.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aCdxwui7http://schemas.devexpress.com/winfx/2008/xaml/windowsui  5      Adxca6http://schemas.devexpress.com/winfx/2008/xaml/carousel  5      ]	 YDevExpress.Mvvm.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm 	  5	      OCustomBhttp://schemas.devexpress.com/winfx/2008/xaml/windowsui/navigation  5
      f
 bDevExpress.Xpf.Grid.v17.2.Core, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v17.2, Version=17.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid 
  5      @dxp6http://schemas.devexpress.com/winfx/2008/xaml/printing  5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5        � 	Resources  5         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� Value	 �� 
TargetName
 �� Property��%  &	        �� 5   
   " ��5      .R�5      �� $ Bd��5      #��z��5      
���   �#��z��5      $ 10��5      ._�5      �� $ PART_ContentHost��6   5       5      P� 5       � {� .  . �5       �� # � ��5!      $	 Bd��5"      
 � ���� 5#      # � ��5$      
 � ��5%      P� 5&       � ��$
 Auto��5'      . �5(      �� 
 � ��$	 100��5)      5*      P� 5+       � ��$
 Auto��5,      . �5-      �� 
 � ��$ 30��5.      5/      51      53      .��55      ]� .+�57   
   )  #DevExpress.Xpf.Ribbon.RibbonControl  -   5        $	��Top=�57         RibbonStyle$ 
Office2010=�58         
Categories. 5;      5  /DevExpress.Xpf.Ribbon.RibbonDefaultPageCategory  2  ,DevExpress.Xpf.Ribbon.RibbonPageCategoryBase   Pages. 5<      &   DevExpress.Xpf.Ribbon.RibbonPage     Caption)  #DevExpress.Xpf.Core.ObjectConverter$
 Home 6!   5>      5?      5@      )  #DevExpress.Xpf.NavBar.NavBarControl  5A   
   -   5          Name$ navbar��5B      $	��231��5A         AllowSelectDisabledItem .  $
��Left=�5D      $��	0,0.4,0,1q�5E         Groups. 5G      '  !DevExpress.Xpf.NavBar.NavBarGroup  -   5          Name$ NormalPatientList��5G         Header$ Normal Patients List 5H         DisplayMode$ ImageAndText=�5I         ImageSource 5J      *  $DevExpress.Xpf.Core.DXImageExtension     Image1	  +DevExpress.Xpf.Core.Native.DXImageConverter$ BOPerson_32x32.png	    Items. 5K      &
   DevExpress.Xpf.NavBar.NavBarItem
  -   5         
 Name$ NormalPatients��5K   !    
  Content$ Normal Patients 5L   !    
  DisplayMode$ ImageAndText=�5N   !    
  ImageSource 5M   !     $ BOPerson_16x16.png	 5N   !   5P        5Q      -   5        $ BookingPatient��5Q      $ Booking Patients List 5R      $ ImageAndText=�5S       5T        $ BOResume_32x32.png	 . 5U      
  -   5        $ BookingPatients��5U   !   $ Booking Patients 5V   !   $ ImageAndText=�5W   !    5X   !     $ BOResume_16x16.png	 5Y        5Z      -   5        $ DoctorInformation��5Z      $ Doctor Information Lists 5[      $ ImageAndText=�5\       5]        $ BOCustomer_32x32.png	 . 5^      
  -   5        $ 
DoctorList��5^   !   $ Doctor Lists 5_   !   $ ImageAndText=�5`   !    5a   !     $ BOCustomer_16x16.png	 5b        5c      -	   5        $ ReferDoctorInformation��5c      $$ Refer Doctor Information Lists 5d      $ ImageAndText=�5e       5f        $ BOCustomer_32x32.png	 . 5g      
  -
   5        $ ReferDoctorList��5g   !   $ Refer Doctor Lists 5h   !   $ ImageAndText=�5i   !    5j   !     $ BOCustomer_16x16.png	 5k      5m      .  (DevExpress.Xpf.WindowsUI.NavigationFrame  5n   
   -   5          Name$ navframe��5n          AnimationType$ SlideHorizontal=�5o       2  ,DevExpress.Mvvm.UI.Interactivity.Interaction   	Behaviors 5q      @  :DevExpress.Xpf.WindowsUI.Navigation.FrameNavigationService  5r      5u      5w      5x      