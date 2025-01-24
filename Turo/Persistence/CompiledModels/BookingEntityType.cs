﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Turo.Domain.Entities;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Turo.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class BookingEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Turo.Domain.Entities.Booking",
                typeof(Booking),
                baseEntityType,
                propertyCount: 21,
                navigationCount: 2,
                foreignKeyCount: 3,
                unnamedIndexCount: 3,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(string),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var carId = runtimeEntityType.AddProperty(
                "CarId",
                typeof(int),
                propertyInfo: typeof(Booking).GetProperty("CarId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<CarId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            carId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var carId1 = runtimeEntityType.AddProperty(
                "CarId1",
                typeof(string),
                nullable: true);
            carId1.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdAt = runtimeEntityType.AddProperty(
                "CreatedAt",
                typeof(DateTime),
                propertyInfo: typeof(Booking).GetProperty("CreatedAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<CreatedAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createdAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createdBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdDate = runtimeEntityType.AddProperty(
                "CreatedDate",
                typeof(DateTime),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("CreatedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<CreatedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createdDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var endDate = runtimeEntityType.AddProperty(
                "EndDate",
                typeof(DateTime),
                propertyInfo: typeof(Booking).GetProperty("EndDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<EndDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            endDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isPaid = runtimeEntityType.AddProperty(
                "IsPaid",
                typeof(bool),
                propertyInfo: typeof(Booking).GetProperty("IsPaid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<IsPaid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isPaid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedBy = runtimeEntityType.AddProperty(
                "ModifiedBy",
                typeof(string),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("ModifiedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<ModifiedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDate = runtimeEntityType.AddProperty(
                "ModifiedDate",
                typeof(DateTime?),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("ModifiedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<ModifiedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var paymentDetails = runtimeEntityType.AddProperty(
                "PaymentDetails",
                typeof(string),
                propertyInfo: typeof(Booking).GetProperty("PaymentDetails", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<PaymentDetails>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            paymentDetails.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var paymentMethod = runtimeEntityType.AddProperty(
                "PaymentMethod",
                typeof(string),
                propertyInfo: typeof(Booking).GetProperty("PaymentMethod", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<PaymentMethod>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            paymentMethod.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var renterId = runtimeEntityType.AddProperty(
                "RenterId",
                typeof(int),
                propertyInfo: typeof(Booking).GetProperty("RenterId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<RenterId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            renterId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var renterId1 = runtimeEntityType.AddProperty(
                "RenterId1",
                typeof(string),
                nullable: true);
            renterId1.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowVersion = runtimeEntityType.AddProperty(
                "RowVersion",
                typeof(string),
                propertyInfo: typeof(BaseEntity<string>).GetProperty("RowVersion", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BaseEntity<string>).GetField("<RowVersion>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowVersion.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var startDate = runtimeEntityType.AddProperty(
                "StartDate",
                typeof(DateTime),
                propertyInfo: typeof(Booking).GetProperty("StartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<StartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            startDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var status = runtimeEntityType.AddProperty(
                "Status",
                typeof(BookingStatus),
                propertyInfo: typeof(Booking).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            status.SetSentinelFromProviderValue(0);
            status.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var totalPrice = runtimeEntityType.AddProperty(
                "TotalPrice",
                typeof(double),
                propertyInfo: typeof(Booking).GetProperty("TotalPrice", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<TotalPrice>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0.0);
            totalPrice.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var updatedAt = runtimeEntityType.AddProperty(
                "UpdatedAt",
                typeof(DateTime),
                propertyInfo: typeof(Booking).GetProperty("UpdatedAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<UpdatedAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            updatedAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userId = runtimeEntityType.AddProperty(
                "UserId",
                typeof(string),
                nullable: true);
            userId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { carId1 });

            var index0 = runtimeEntityType.AddIndex(
                new[] { renterId1 });

            var index1 = runtimeEntityType.AddIndex(
                new[] { userId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CarId1") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var car = declaringEntityType.AddNavigation("Car",
                runtimeForeignKey,
                onDependent: true,
                typeof(Car),
                propertyInfo: typeof(Booking).GetProperty("Car", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<Car>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var bookings = principalEntityType.AddNavigation("Bookings",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Booking>),
                propertyInfo: typeof(Car).GetProperty("Bookings", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Car).GetField("<Bookings>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RenterId1") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var renter = declaringEntityType.AddNavigation("Renter",
                runtimeForeignKey,
                onDependent: true,
                typeof(IndividualUser),
                propertyInfo: typeof(Booking).GetProperty("Renter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Booking).GetField("<Renter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var bookings = principalEntityType.AddNavigation("Bookings",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Booking>),
                propertyInfo: typeof(IndividualUser).GetProperty("Bookings", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IndividualUser).GetField("<Bookings>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("UserId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var bookings = principalEntityType.AddNavigation("Bookings",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Booking>),
                propertyInfo: typeof(User).GetProperty("Bookings", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(User).GetField("<Bookings>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Booking");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
